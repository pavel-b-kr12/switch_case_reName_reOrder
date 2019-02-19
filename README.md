# switch_case_reName_reOrder
software helps to rename or reorder switch cases with increment if needed


### increment if last was not less
```
case 2: .....  
case 4:  
//case 4:  
>>  
case 2:  
case 4:  
//case 5:  
```
C#  
process online:  
https://tio.run/##TY5NS8NAEEDPnV8x7CkhmtRUL7uk9OJBkCCt2IN6WOJYFpJt2NlApPSvG7OJ0F6GeTNvPiq@rdgM7J2xB@QCNgIQK82EdxLzHBVcIFCWzd0HiVrrwBPeS1itQKjBWI@1Zl8WSwVcbKmtdUURIN8AbsTHVyLFmDXFGvA0nsIwUBYv2jFFTfqm647SXVsbHwkp4vflZ6wm7Tsq19PiGAOfYDGfKRUsHPnOWSyTcWSyzyFQPT527SbJxZ0LV/4ZYjXsnfH0bCxFPNLvsfXmaHnIOrn7YU9N@kq9T7d06GrtHvvWEXMwQol69S89Wb/K/wA


### increment reorder from first
```
case 2: .....  
case 4:  
//case 4:  
>>  
case 2: ..... 
case 3:  
//case 4:  
```
C#  
process online:  
https://tio.run/##TY0xa8MwEIXn6Fccmmzc2I3dLhIuWToUiilJaYa2g3CvQSArRieDS8hfryvFgXQ57r373ruWli3pibzTdg9UszVnAK0ihJWAsgTJriKqopiv9wKUUlGf5Z1gVcW4nLT1YBT5pl6uJKN6g71RLSYM6IbBmn98ZYKHrasfGBzDL9DfyRwIiTQaR7aILU39ohxh0uVvygyYb3ujfcIFT99vP1PJFnOqCZtDPzgLTRauMlac4kBDeOk7o1l2RWfjH35iqZx2Tnt81hYTCur30Ht9sDQVg9j@kMcuf8XR5xvcD0a5x7F3SBSJaOEoL9CT9VX5Bw

### disable (comment out) marked cases
```
case 2: ..... //not168  
case 4:   //not328  
//case 4:s  
>>  
//case 2: ..... //not168  
case 4:   //not328  
//case 4:s    
```
C#  
process online:  
https://tio.run/##XZBNS8QwEIbPzq8Ycmr9SHQVWRoqC@JBUA@7oudQxiXYpCWTQmXZv25N3ArqHGaYd575YBo@a9hOHIP1W@QaVgIRoTFMuKhQZkOlfBcvrpcH@apKxLd0uViCUrPIIPTPnKZzjnx8NOG9FodeoQGsj9gajk/1uQau19S3pqECkE8BV0IeixRdfQO4g7TDvhVOvph2IHnb@Wis5@LX5LLETO3gKFAcgkehlDiZO3Qu7bOjNp33F/zH7KHU02uwkR6sp4JT9tn10XaeJzVUmw@O5OQzjVGuaTu0JtyNfSDmTGSJRj1D9z495Qs


### enable (uncomment) marked cases
```
//case 2: ..... //not168  
case 4:   //not328  
//case 4:s  
>>  
case 2: ..... //not168  
case 4:   //not328  
//case 4:s    
```
C#  
process online:  
https://tio.run/##VZDBSsQwEIbPzlMMObVSU10XWRoqC@JBUA/roudQxiXYpiWTQmXZV7cm3RY0hwz5@b4/IRVfVWxG9s7YA3IJW4GIkOeVZsJVgTIuzHPb@pu7DUzxugjMFN2uNgu7LhiEWpqqtmnI@hftvkpxdoUCMNZjrdm/ltcKuNxRV@uKEkDOALdCXoowm/Ie8AjhDvOZNPJd1z3Jh9Z6bSwnf5rTFCN1hAtHvncWl75ZykLh9DaRifNMVRROcaM6BP/1WVuYE6Rq/HDG07OxlHA4/bSdN63lMe@Lt2/21Mg9DV7u6NDX2j0OnSPmSMSIBjVDTzZ81S8
### TODO
please write in pyton with file input-output, so we can use drag and drop

compile mono console

