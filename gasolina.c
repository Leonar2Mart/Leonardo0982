#include <stdio.h>

#define tirePerf 45000 // Km
#define anualKm 15000 // Km
#define oilChKm 25000 // Km

struct tabla {
    char nombre[20];
    float distance;
    float gFuel;
    float gVar;
    float total;
};

void getInfo(struct tabla *ptrTabla);
float gComb(float D, float eMx, float eMn, float fl);
float vCost(float D, float tireCost, float ensCost, float oilCost);
void print(struct tabla tabla0);

int main() {
    float comb, eMax, eMin, tireC, ensC, oilChange;
    struct tabla tabla0;

    printf("\nCalculo de costo por visita.");
    printf("\nIngrese los siguientes datos.");
    printf("\nPrecio del Combustible (RD$xGal): ");
    scanf("%f", &comb);
    printf("\nEficiencia Maxima del Vehiculo (L/100km): ");
    scanf("%f", &eMax);
    printf("\nEficiencia Minima del Vehiculo (L/100km): ");
    scanf("%f", &eMin);
    printf("\nPrecio de las llantas (RD$xUnidad): ");
    scanf("%f", &tireC);
    printf("\nCosto del Seguro Anual (RD$): ");
    scanf("%f", &ensC);
    printf("\nCosto de Cambio de Aceite (RD$): ");
    scanf("%f", &oilChange);

    getInfo(&tabla0);
    tabla0.gFuel = gComb(tabla0.distance, eMax, eMin, comb);
    tabla0.gVar = vCost(tabla0.distance, tireC, ensC, oilChange);
    tabla0.total = tabla0.gFuel + tabla0.gVar;
    print(tabla0);

    return 0;
}

void getInfo(struct tabla *ptrTabla) {
    printf("\nNombre del cliente: ");
    fflush(stdin);
    gets(ptrTabla->nombre);
    fflush(stdin);
    printf("\nDistancia a recorrer (Km): ");
    scanf("%f", &(ptrTabla->distance));
}

float gComb(float D, float eMx, float eMn, float fl) {
    float newCombPrice = fl / 3.71;
    float eProm = ((eMx + eMn) / 2) / 100;
    return newCombPrice * eProm * D;
}

float vCost(float D, float tireCost, float ensCost, float oilCost) {
    float totalTireC = 4 * tireCost;
    float tirePerKM = totalTireC / tirePerf;
    float ensPerKm = ensCost / anualKm;
    float oilCostPerKm = oilCost / oilChKm;
    return tirePerKM + ensPerKm + oilCostPerKm;
}

void print(struct tabla tabla0) {
    printf("\n-------------------------------------------");
    printf("\n| Cliente: %-19s |", tabla0.nombre);
    printf("\n-------------------------------------------");
    printf("\n| Costo   | Distancia | Combustible | Gastos Varios | Total   |");
    printf("\n-------------------------------------------");
    printf("\n| %7.2f | %9.2f | %11.2f | %13.2f | %7.2f |",
           tabla0.gFuel, tabla0.distance, tabla0.gFuel * 3.78541, tabla0.gVar, tabla0.total);
    printf("\n-------------------------------------------");
}