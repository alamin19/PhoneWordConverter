using System.Threading.Tasks;

namespace PhoneWordConverter
{
    public interface IDailer
    {
        Task<bool> DialAsync(string number);
    }
}