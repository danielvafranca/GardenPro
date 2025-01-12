using System;

namespace GardenPro.Models;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Adress { get; set; }
    public string PhoneNumber{ get; set; }
    public decimal MonthlyPayment { get; set; }
    public int MonthlyPaymentStatus { get; set; }// 1 sim 2 nao 3 atraso
    public int WeeklyStatusWork { get; set; }// 1 sim 2 nao 3 atraso

}
