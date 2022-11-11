namespace hospital;
 class InHousePatient : Patient {
	
	public double Discount {get; set;}

	public InHousePatient(int PatientId, string PatientName, int BedType, int NoOfdays, double Discount)
	{
		base.PatientId = PatientId;
        base.PatientName = PatientName;
        base.BedType = BedType;
        base.NoOfDays = NoOfdays;
        this.Discount = Discount; 
	}
	public double getDiscount(){
		return Discount;
	}
	public override double GetBillAmount()
	{
		
		double i = base.GetBillAmount();

		if(i >= 5000)
			return i - ( i * Discount);
		return i;
	}
	
}
