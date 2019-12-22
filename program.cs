using System;
using SMS_Entity;

class EngStud:Student
{
	public int id
	{
		get
		{
			return id;
			
		}
		set
		{
			set id=value;
		}
		public int name
		{
		get
		{
			return name;
			
		}
		set
		{
			set name=value;
		}
		
		public void show()
		{
			Console.WriteLine();
			
		}
		class Program
		{
			public  void Main(string[] args )
			{
				EngStud engstud=new EngStud();
				engstud.id=1;
				engStud.name="aish";
				
			}
			
		}
		
		
	}
	
	
}