using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mindfulness_Hub_V3.Repository
{
    public interface IPasswordManager
    {
        String GenerateSha256Hash(String input, String salt);

        List<string> GeneratePassword(String input, int saltSize);
    }
}
