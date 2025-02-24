﻿using SchoolReinforcement.Entities.Requests;

namespace SchoolReinforcement.Interfaces.Service
{
    public interface IService <T> where T : class
    {
        T GetById(int id);
        List<T> GetAll();
        void Create(CreateStudentRequest request);
    }
}
