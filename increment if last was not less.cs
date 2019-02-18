string s=
@"
  case 1: 22 ;
case 1: 222 ;
// case 5: aaa;
//case 4:
33
";


int lastN=-1;
s = Replace(
 s,
 @"\d+:",
 m=>
 {
   if(lastN==-1)
   {
	int N=Parse(m.Value.Split(":")[0]);
	lastN=N;
	return N+":";
   }
   else
   {
	lastN++;
	return lastN+":";
   }
 }
);