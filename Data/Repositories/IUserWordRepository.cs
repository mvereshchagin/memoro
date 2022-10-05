using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data.Repositories;

public interface IUserWordRepository : IDataRepository<UserWord>
{
    List<UserWord> GetByStatus(WordStatus status);
}
