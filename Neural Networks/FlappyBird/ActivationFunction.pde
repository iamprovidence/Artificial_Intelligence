public float Identity(float x)
{
    return x;
}
public float Sigmoid(float x)
{
    return 1 / (1 + pow(exp(1.0), -x));
}
public float Tanh(float x)
{
    return tan(x);
}
public float ArcTan(float x)
{
    return atan(x);
}
public float Softsign(float x)
{
    return 1 / (1 + abs(x));
}
public float Relu(float x)
{
    if (x >= 0) return x;
    return 0;
}
public float Leaky_Relu(float x)
{
    if (x >= 0) return x;
    return 0.01 * x;
}
    
