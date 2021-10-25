### Used Environments:

| Visual Studio 2022 | Rider | Net | NUnit |
| --- | --- | --- | --- |
| Version 17.0.0 Preview 6.0 | JetBrains Rider 2021.3 EAP 5 | 5.0 | 3.13.2 |

### Sample:

```bash
 git clone https://renepeuser.visualstudio.com/Rider.NUnit.Issue/_git/Rider.NUnit.Issue
```

### Problems:

1. Real world application
   * In real application all test are "Uncaetgorized" 
   * The test are not able to start
   * We are not able to run any test in our constellation
2. Small test application
   * In small test assembly after running "Uncategorized" test had run all test categories will be detected
   * If we add new test the new one will NOT detected. 