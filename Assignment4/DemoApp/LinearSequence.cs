namespace Series;
public class LinearSequence : Sequence 
{

	private double current;
	private float step;

	public LinearSequence(float first, float difference) {
		current = first;
		step = difference;
	}

	public override double next() {
		
		double term = current;
		current += step;
		return term;
	}
		

}
