using BaiCiZhanDAL;
using BaiCiZhanModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCiZhanBLL
{
    public class BLL_Coures
    {
        DAL_Coures dc = new DAL_Coures();

        public int AddCoures(Coures c)
        {
            return dc.AddCoures(c);
        }

        public int UpdateCoures(Coures c)
        {
            return dc.UpdateCoures(c);
        }

        public int DeleteCoures(Coures c)
        {
            return dc.DeleteCoures(c);
        }

        public List<Coures> SeleteCoures()
        {
            return dc.SeleteCoures();
        }
        public List<Coures> select(int id)
        {
            return dc.select(id);
        }
    }
}
