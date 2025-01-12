using System;

namespace GardenPro.Models;
public class Role
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Slug { get; set; }

    public Ilist<User> Users { get; set; }
}
	

