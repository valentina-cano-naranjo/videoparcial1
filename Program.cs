// Velocidades de los trenes en km/h
int velocidadPrimerTren = 80;
int velocidadSegundoTren = 100;

// Tiempo en horas cuando sale el segundo tren
int horaSalidaSegundoTren = 11;
int minutosSalidaSegundoTren = 0;

// Tiempo en horas cuando sale el primer tren
int horaSalidaPrimerTren = 10;
int minutosSalidaPrimerTren = 0;

// Convertir todo a minutos
int tiempoPrimerTren = horaSalidaPrimerTren * 60 + minutosSalidaPrimerTren;
int tiempoSegundoTren = horaSalidaSegundoTren * 60 + minutosSalidaSegundoTren;

// Calcular el tiempo que el segundo tren tarda en alcanzar al primer tren
int tiempoDeAlcance = (int)(((double)tiempoSegundoTren - tiempoPrimerTren) / (velocidadSegundoTren - velocidadPrimerTren) * 60);

// Calcular la hora de alcance
int horaDeAlcance = horaSalidaSegundoTren + tiempoDeAlcance / 60;
int minutosDeAlcance = tiempoDeAlcance % 60;

Console.WriteLine($"El segundo tren alcanzará al primer tren a las {horaDeAlcance}:{minutosDeAlcance:D2}.");

