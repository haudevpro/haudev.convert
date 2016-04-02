# HauDev.Convert Là thư viện convert kiểu dữ liệu.
Convert Table To List<br/><br/>
Ví dụ:<br/>
+Convert Kiểu dữ liệu.<br/>
string te="21";<br/>
int ketqua=te.To<int>();<br/><br/>
+Convert DataTable sang List object.<br/>
public class Test{<br/>
  public int Id{get;set;}<br/>
  public string Name{get;set;}
}<br/>
DataTable dt= new DataTable();<br/>
dt.Columns.Add("Id");<br/>
dt.Columns.Add("Name");<br/>
List<Test> listTest=dt.ToList<<>>();<br/>
