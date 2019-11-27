using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eventer.Domain;
using Eventer.Domain.Models;
using Eventer.Domain.Models.Dtos;

namespace Eventer.AspNetCore.Services
{
    class TestModelService : ITestModelService
    {
        private readonly IRepository<TestModel> _repository;

        public TestModelService(IRepository<TestModel> repository)
        {
            _repository = repository;
        }

        public void AddTestModel(AddTestModelDto addTestModelDto)
        {
            TestModel testModel = new TestModel()
            {
                Value = addTestModelDto.Value
            };
            _repository.Add(testModel);
        }

        public GetTestModelDto GetTestModel(int id)
        {
                IEnumerable<TestModel> testModels = _repository.Get();
                var testModel = testModels.FirstOrDefault(x => x.Id == id);
                if (testModel != null)
                {

                    var getTestModelDto = new GetTestModelDto()
                    {
                        Id = testModel.Id,
                        Value = testModel.Value
                    };

                    return getTestModelDto;
                }

                return null;
            }
    }
}
