using Eventer.Domain.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventer.AspNetCore.Services
{
    public interface ITestModelService
    {
        GetTestModelDto GetTestModel(int id);
        void AddTestModel(AddTestModelDto addTestModelDto);
    }
}
