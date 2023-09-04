# AddingBigNumbers
Code wars kata: Adding Big Numbers https://www.codewars.com/kata/525f4206b73515bffb000b21/train/csharp

## Overview
The object is to create a method to sum two potentially very large numbers represented as strings.

## Method Details
```csharp
public static string Add(string a, string b)
```

* The method is designed to handle string numbers, which could be potentially very large, larger than what normal integer data types can hold.
* The function reverses the input strings and aligns them in such a way that the longer string is always string1 and the shorter one is string2.
* The addition is performed from the least significant digit (rightmost digit) to the most significant one (leftmost digit) like standard addition.
* If the sum of two digits (along with any carry from the previous step) exceeds 9, a carry is set for the next addition step.
* The result is built from the rightmost to the leftmost digit, ensuring the correct order of digits in the result string.

## Example
```csharp
Kata.Add("789", "123");  // Returns "912"
Kata.Add("999", "1");    // Returns "1000"
Kata.Add("1234567890", "9876543210") // Returns "11111111000"
Kata.Add("5050505050", "4949494949") => // Returns "9999999999"
```

## Notes
* The code handles the possibility of an overflow (carryover after the last digit addition).
* The method does not handle negative string numbers or strings with non-numeric characters.
