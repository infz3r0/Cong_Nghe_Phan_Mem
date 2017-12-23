using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DATA_Tier
{
    public class SinhVienDAO:DBConnect
    {
        public DataTable getAll()
        {
            string query = "SELECT MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, SoCMND, Sdt, Email FROM SinhVien";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }

    }
}
