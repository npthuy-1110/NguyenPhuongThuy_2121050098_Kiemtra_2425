using System.ComponentModel.DataAnnotations;
namespace KiemtradiemB;
public class Demoabc
{
[Key]
    public int PesonId { get; set; }
    public string Fullname { get; set;}
    public Double Diem { get ; set;}
}
