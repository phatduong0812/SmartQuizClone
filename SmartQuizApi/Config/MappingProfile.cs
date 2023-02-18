﻿using AutoMapper;
using SmartQuizApi.Data.DTOs.AnswerDTOs;
using SmartQuizApi.Data.DTOs.BiilDTOs;
using SmartQuizApi.Data.DTOs.GradeDTOs;
using SmartQuizApi.Data.DTOs.QuestionDTOs;
using SmartQuizApi.Data.DTOs.SchoolDTOs;
using SmartQuizApi.Data.DTOs.StudySetDTOs;
using SmartQuizApi.Data.DTOs.SubjectDTOs;
using SmartQuizApi.Data.DTOs.UserDTO;
using SmartQuizApi.Data.Models;

namespace SmartQuizApi.Config
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<CreateStudySetDTO, StudySet>();
            CreateMap<Grade, GetAllGradesDTO>();
            CreateMap<Subject, GetSubjectsDTO>();
            CreateMap<StudySet, GetStudySetDetailsDTO>().ForMember(dest => dest.Creator, opt => opt.MapFrom(src => src.User.Name));
            CreateMap<Question, GetQuestionDTO>();
            CreateMap<Answer, GetAnswerDTO>();
            CreateMap<StudySet, GetStudySetsListDTO>().ForMember(des => des.Creator, opt => opt.MapFrom(src => src.User.Name));
            CreateMap<CreateQuestionDTO, Question>();
            CreateMap<CreateAQuestionDTO, Question>();
            CreateMap<CreateAnwserDTO, Answer>();
            CreateMap<UpdateStudySetDTO, StudySet>().ForMember(des => des.Id, opt => opt.Ignore());
            CreateMap<UpdateQuestionDTO, Question>();
            CreateMap<UpdateAnswerDTO, Answer>();
            CreateMap<SubjectsOfGrade, GetStudySetDetailsDTO>().ForMember(des => des.Id, opt => opt.Ignore())
                                                                .ForMember(des => des.SubjectName, opt => opt.MapFrom(src => src.Subject.Name))
                                                                .ForMember(des => des.GradeName, opt => opt.MapFrom(src => src.Grade.Name));
            CreateMap<SubjectsOfGrade, GetStudySetsListDTO>().ForMember(des => des.Id, opt => opt.Ignore())
                                                                .ForMember(des => des.SubjectName, opt => opt.MapFrom(src => src.Subject.Name))
                                                                .ForMember(des => des.GradeName, opt => opt.MapFrom(src => src.Grade.Name));
            CreateMap<CreateBill, Bill>();
            CreateMap<User, UserInfoDTO>();
            CreateMap<CreateUserInfor, User>();
        }
    }
}
