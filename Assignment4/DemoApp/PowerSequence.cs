using Series;

public class PowerSequence : Sequence ,IResetable {

	private double current;
	private float factor;

	public PowerSequence(float ratio) {
		current = 1;
		factor = ratio;
	}

	public override double next() {
		
		double term = current;
		current *= factor;
		return term;
	}


    public void reset() {
		current = 1;
	}

		

}