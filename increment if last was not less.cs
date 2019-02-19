string s=
@"
  case 1: 22 ;
case 1: 222 ;
// case 5: aaa;
//case 4:
33
";


int lastN=0;
s=Replace(
 s,
 @"\d+:",
 m=>
 {
   int N=Parse(m.Value.Split(":")[0]);
   if(N>lastN) 
   {
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
