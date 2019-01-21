//setup
double itemWeight = 0.0;

//input

" Please enter the weight of the shipping item in lb.")

get itemWeight

//process

if (itemWeight<=2)
{
get cost = 2;
	
}
else if (itemWeight >2 && itemWeight <=6)
{
getcost = 4;
}
else if (itemWeight >6 && itemWeight <= 10)
{
get cost = 6;
}
else
{
get cost = 8;
}
//output

"The cost of shipping" +itemWeight+ is $"+ cost