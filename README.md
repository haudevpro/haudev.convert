# HauDev.Convert Là thư viện convert kiểu dữ liệu.
Convert Table To List
Ví dụ:
+Convert Kiểu dữ liệu.
string te="21";
int ketqua=te.To<int>();
+Convert DataTable sang List object.
public class Test{
  public int Id{get;set;}
  public string Name{get;set;}
}
DataTable dt= new DataTable();
dt.Columns.Add("Id");
dt.Columns.Add("Name");

List<Test> listTest=dt.ToList<Test>();


