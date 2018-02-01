

function pasu(){
	if (Time.timescale == 1.0)
		Time.timescale = 0;

	else
		Time.timescale = 1.0;
		Time.fixedDeltaTime = 0.02 * Time.timescale;
}