using OrganizeIt.Tasks.Persistence.Contexts;
using OrganizeIt.Tasks.Application.Common.Mappings;
using AutoMapper;

namespace  OrganizeIt.Tasks.Application.UnitTests.Mocks.Persistence
{
    public static class  AutoMapperMock
    {
        public static IMapper mapper;

        static AutoMapperMock()
        {
            var mapperConfiguration = new MapperConfiguration(c => {
                c.AddProfile<AutoMapperProfile>();
            });

            mapper = mapperConfiguration.CreateMapper();
        }        
    }
}