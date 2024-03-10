using SepandarTest.Model;

namespace SepandarTest.Persistence
{
    public class DatabaseMockup
    {
        public DatabaseMockup() { }

        public async Task<List<GetMobileByPlkDto>> GetMobileByPlkBatch(List<GetMobileByPlkModel> model)
        {
            Random random = new();
            List<GetMobileByPlkDto> output = new();

            foreach (var modelItem in model)
            {
                output.Add(new GetMobileByPlkDto { Id = modelItem.Id, Mobile = random.NextInt64(9120000000, 9129999999).ToString("D11") });
            }

            return output;
        }
    }
}
