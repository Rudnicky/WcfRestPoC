using System.Collections.Generic;
using System.Linq;

namespace WcfRestPoC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CustomService : ICustomService
    {
        public CustomModel GetCustomModel(string customModelId)
        {
            var customModels = new List<CustomModel>
            {
                new CustomModel() { Id = "1", Name = "Custom 1" },
                new CustomModel() { Id = "2", Name = "Custom 2" },
                new CustomModel() { Id = "3", Name = "Custom 3" },
                new CustomModel() { Id = "4", Name = "Custom 4" }
            };

            return customModels.Where(x => x.Id == customModelId).FirstOrDefault();
        }

        public List<CustomModel> GetCustomModels()
        {
            var customModels = new List<CustomModel>
            {
                new CustomModel() { Id = "1", Name = "Custom 1" },
                new CustomModel() { Id = "2", Name = "Custom 2" },
                new CustomModel() { Id = "3", Name = "Custom 3" },
                new CustomModel() { Id = "4", Name = "Custom 4" }
            };

            return customModels;
        }
    }
}
