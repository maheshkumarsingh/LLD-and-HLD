#include<bits/stdc++.h>
using namespace std;

class ComplexNumber {
    public :
       
        float real, imaginary;
       
        // Define constructor here
        ComplexNumber(float realPart,float imaginaryPart){
            real = realPart;
            imaginary = imaginaryPart;
        }
       
       
        ComplexNumber add(ComplexNumber x){
            // Complete the function
           
            float realPart = real + x.real;
            float imaginaryPart = imaginary + x.imaginary;
            return ComplexNumber(realPart,imaginaryPart);
           
        }
       
        ComplexNumber subtract(ComplexNumber x){
            // Complete the function
            float realPart = real - x.real;
            float imaginaryPart = imaginary - x.imaginary;
            return  ComplexNumber(realPart,imaginaryPart);
        }
       
        ComplexNumber multiply(ComplexNumber x){
            // Complete the function
            float realPart = real * x.real - imaginary * x.imaginary;
            float imaginaryPart = real * x.imaginary + imaginary * x.real;
            return ComplexNumber(realPart,imaginaryPart);
           
        }
       
        ComplexNumber divide(ComplexNumber x){
            // Complete the function
            float a = real;
            float b = imaginary;
            float c = x.real;
            float d = x.imaginary;
            float realPart = (a * c + b * d ) / (c*c + d*d);
            float imaginaryPart = (b*c - a*d)/(c*c + d*d);
            return ComplexNumber(realPart,imaginaryPart);
           
        }
};



int main()
{
   system("cls");
   int test_cases;
	cin>>test_cases;
	for(int i = 0 ; i < test_cases ; i++){
		int a1,a2,b1,b2;
		cin>>a1>>a2;
		cin>>b1>>b2;
    
		ComplexNumber a(a1, a2);
		ComplexNumber b(b1, b2);
		ComplexNumber c1 = a.add(b);
    	ComplexNumber c2 = a.subtract(b);
    	ComplexNumber c3 = a.multiply(b);
    	ComplexNumber c4 = a.divide(b);
		cout<<fixed<<setprecision(2);
		cout<<c1.real<<endl;
	    cout<<c1.imaginary<<endl;
		cout<<c2.real<<endl;
	    cout<<c2.imaginary<<endl;
	    cout<<c3.real<<endl;
	    cout<<c3.imaginary<<endl;
	    cout<<c4.real<<endl;
	    cout<<c4.imaginary<<endl;
    }
   return 0;
}