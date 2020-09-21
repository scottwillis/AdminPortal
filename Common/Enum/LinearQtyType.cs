namespace Common {

	public enum LinearQtyType {
		PerEntireRow = 0,
		PerFixture = 1,
		PerFixtureMinus1 = 2,
		PerFixtureExceptStandalone = 3,
		InchesPerQty = 4,
		PerFixureType = 5, //Looks at the Fixture type (i.e. feeder / joiner to determine what parts to apply)
		PerMxCustom = 6,
        PerCorner = 7

	}

}
