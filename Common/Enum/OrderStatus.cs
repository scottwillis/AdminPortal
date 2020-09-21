namespace Common {

	public enum OrderStatus {
		Cancelled = -10,
		Staged = -3,
		Oasis = -2,
		Cahill = -1,
		EnteredHold = 0,
		Released = 1,
		BillOfMaterial = 2,
		Scheduled = 3,
		InAssembly = 5,
		Assembled = 6,
		BillOfLading = 7,
		Invoiced = 8,
		PaidComplete = 9,
	}

}
