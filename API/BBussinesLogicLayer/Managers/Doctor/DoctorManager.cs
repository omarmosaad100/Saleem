using AutoMapper;
using BBussinesLogicLayer.Dtos.Admin;
using BBussinesLogicLayer.Dtos.Doctor;
using CDataAccessLayer.Data;
using CDataAccessLayer.Data.Models;
using CDataAccessLayer.Repos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Managers.Doctor
{
    public class DoctorManager: IDoctorManager
    {
        private readonly IDoctorRepo _doctorRepo;
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public DoctorManager(IDoctorRepo doctorRepo, IMapper mapper, DataContext context) 
        {
            _doctorRepo = doctorRepo;
            _mapper = mapper;
            _context = context;
        }
        public int AddAppointment(AppointmentDto appointmentDto)
        {
            //AppointmentDetails newAppointment = _mapper.Map<AppointmentDetails>(appointmentDto);


            AppointmentDetails newAppointment = new AppointmentDetails
            {
                Id = appointmentDto.Id,
                Date = appointmentDto.Date,
                Comment = appointmentDto.Comment,
                PId = appointmentDto.PId,
                DId = appointmentDto.DId,
                Specialization = appointmentDto.Specialization,
                DescribedDrugs = appointmentDto.DescribedDrugs.Select(id => _context.Drugs.FirstOrDefault(p => p.Id == id)).ToList(),
                DiagnosedIssues = appointmentDto.DiagnosedIssues.Select(id => _context.Issues.FirstOrDefault(p => p.Id == id)).ToList(),

            };

            return _doctorRepo.AddAppointment(newAppointment);
        }

        public HashSet<DisplayedAppointmentDto> GetAppointmentsByNid(string nid)
        {
            var appointments = _doctorRepo.GetAppointmentsByNid(nid);

            HashSet<DisplayedAppointmentDto> displayedAppointments = new();

            foreach (var app in appointments)
            {
                DisplayedAppointmentDto newDisplayedApp = new()
                {
                    Date = app.Date,
                    Comment = app.Comment,
                    DId = app.DId,
                    DescribedDrugs = app.DescribedDrugs.Select(drug => _context.Drugs.FirstOrDefault(d => d.Id == drug.Id).Name).ToHashSet(),
                    DiagnosedIssues = app.DiagnosedIssues.Select(issue => _context.Issues.FirstOrDefault(i => i.Id == issue.Id).Name).ToHashSet(),
                    Specialization = app.Specialization,

                };

                displayedAppointments.Add(newDisplayedApp);
            }

            return displayedAppointments;

        }

        public DoctorProfileDto GetDoctorProfileById(string did)
        {
            var doctor = _doctorRepo.GetDoctorProfileById(did);

            return _mapper.Map<DoctorProfileDto>(doctor);
        }


        public bool DeleteIssueByPidAndIssueName(string pid, string name)
        {
            return _doctorRepo.DeleteIssueByPidAndIssueName(pid, name);
        }

        public DrugDto GetDrugRecommendation(string issueName, string pid)
        {
            var drug = _doctorRepo.GetDrugRecommendation(issueName, pid);

            return _mapper.Map<DrugDto>(drug);

            
        }
    }
}
