# C-Sharp-Fundamentals-
C# Fundamentals

Notes taken from C# Tutorial "Programming with Mosh" 

1. C# vs .NET
2. Variables/Constants
3. Identifiers
4. Naming Conventions
5. Primitive Types
6. Real Numbers
7. Non-Primitive Types 
8. Overflowing
9. Scope
10. Type Conversion
11. Convert
12. Operators 




1. C# vs .NET

C# is a programming language, while .NET is a framework for building applications on Windows.
.NET has 2 components 1 is CLR (Common Language Runtime) and a Class Library for building applications.





2. Variables/Constants

Variable: a name given to a storage location in memory.
Constant: an immutable value.

int number;
int Number = 1;

Those two identifiers are different.
C# is a case sensitive language, therefore "number" and "Number" are different.

const float Pi = 3.14f;





3. Identifiers 

Identifiers CANNOT start with a number 

1route -Incorrect 

oneRoute - Correct 

Identifiers CANNOT include a white space.

first name - Incorrect 

firstName - Correct. 

Identifiers CANNOT be a reserved keyword.

int - Incorrect

@int - Correct 

Use meaningful names.

fn - It will work, but it looks sloppy.

firstName - Correct 

Using meaningful names helps your code be readable, maintainable and cleaner. 





4. Naming Conventions

Camel Case: firstName
Pascal Case: FirstName
Hungarian Notation: strFirstName -Not Recommended 

For local variables : Camel Case 		int number;
For constants: Pascal Case				const int MaxZoom = 5;





5. Primitive Types

Integral Numbers in C# data types, .Net Type, Bytes & Range (Range meaning can store a value between n-n)

byte, Byte, 1, 0-255
short, Int16, 2, -32,768 - 32,767
int, Int32, 4, -2.1B to 2.1B 
long, Int64, 8, ...

Real Numbers in C# data types, .Net Type, Bytes & Range

float, Single, 4, -3.4 x 10^38 - 3.4 x 10^38
double, Double, 8, ...
decimal, Decimal, 16, -7.9 x 10^28 - 7.9 x 10^28

Characters in c# data types, .Net Type, Bytes & Range

char, Char, 2, Unicode Characters

Boolean in C# data types, .Net Type, Bytes & Range

bool, Boolean, 1, True/False





6. Real Numbers

If you want to declare a float you must put an "f" at the end of the number. 
float number = 1.2f;

If you want to declare a decimal you must put an "m" at the end of the number. 
decimal number = 1.2m;





7. Non-Primitive Types 

String

Array

Enum

Class





8. Overflowing

byte number = 255;

number = number + 1; // 0

the largest value that can be stored in a byte is 255, so if we add a number to it to make it 256, 
when you compile and display "number" you will see 0. - This is called overflowing. You have exceeded 
the boundary of that data type 

C# by default we don't have overflow checking. 
To fix this you can use the "checked" keyword.

checked
{
	byte number  = 255;
	
	number = number + 1;
}

overflow will not happen and the "checked" will throw an exception.
To be honest you probably won't really see this, because what you can do is just replace the byte with a short.




9. Scope

Scope is where a variable/constant has meaning and is accessible. 


{
	byte a = 1;
	
	{
		byte b = 2;
		
		{
			byte c = 3;
		}
	}
}





10. Type Conversion 

Implicit type conversion

e.g. 1

byte b = 1;

int i = b;

e.g. 2
int i = 1;

float f = i;

e.g. 3
This one won't compile

int i = 1;

byte b = i; 


Explicit type conversion (casting)

e.g. 1 

int i = 1;

byte b = (byte)i;

e.g. 2

float f = 1.0f;

int i = (int)f;

e.g. 3
This one won't compile

string s = "1";

int i = (int)s;

Conversion between non-compatible types

e.g. 1 

string s = "1";

int i = Convert.ToInt32(s);

int j = int.Parse(s);





11. Convert

ToByte()

ToInt16() --> short

ToInt32() --> integer

ToInt64() --> long





12. Operators 

Arithmetic Operators

Add + e.g. a + b
Subtract - e.g. a - b
Multiply * e.g. a * b
Divide / e.g. a / b
Remainder % e.g. a % b

Increment ++ e.g. a++ --> a = a + 1
Decrement -- e.g. a-- --> a = a - 1


Comparison Operators

Equal == e.g. a == b
Not Equal != e.g. a != b
Greater than > e.g. a > b
Greater than or equal to >= e.g. a >= b
Less than < e.g. a < b
Less than or equal to <= e.g. a <= b


Assignment Operators

Assignment = e.g. a = 1
Addition assignment += e.g. a += 3 --> a = a + 3
Subtraction assignment -= e.g. a -= 3 
Multiplication assignment *= e.g. a *= 3 
Division assignment /= e.g. a /= 3


Logical Operators

And && e.g. a && b
Or || e.g. a || b
Not ! e.g. !a 


Bitwise Operators

And & e.g. a & b 
Or | e.g. a | b 
