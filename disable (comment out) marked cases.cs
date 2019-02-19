string s=
@"   
case 2: ..... //not168
case 4:   //not328
//case 4:s
";

string commentMark="not168";

int lastN=0;
s=Replace(
 s,
 @".*",
 m=>
 {
   if(m.Value.Contains(commentMark)) 
   {
	return "//"+m.Value;
   }
   else 
   {
	return m.Value;
   }
 }
);


WriteLine(s);