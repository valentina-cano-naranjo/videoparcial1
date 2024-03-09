// Velocidades de los trenes en km/h
int vpt= 80;
int vst = 100;

// Tiempo en horas cuando sale el segundo tren
int hsst = 11;
int msst= 0;

// Tiempo en horas cuando sale el primer tren
int hspt = 10;
int mspt = 0;

// Convertir todo a minutos
int tpt = hspt * 60 + mspt;
int tst= hsst * 60 + msst;

// Calcular el tiempo que el segundo tren tarda en alcanzar al primer tren
int ta = (int)(((double)tst - tpt) / (vst - vpt) * 60);

// Calcular la hora de alcance
int ha = hsst + ta / 60;
int ma = ta % 60;

Console.WriteLine($"El segundo tren alcanzará al primer tren a las {ha}:{ma :D2}.");

