fonk1();
int sayi1;
sayi1=fonk2();
Console.WriteLine("Fonk2-Geri Dönen Bilgi:" + sayi1.ToString());
fonk3("Fonk3 test sayisi",5,(5>3));
int aci3;
aci3=fonk4(78,94);
Console.WriteLine("Fonk4- 3. açı:"+aci3.ToString());

//Fonksiyon 1 
//Parametre Almayan - Geri Dönüş Vermeyen
void fonk1(){
    Console.WriteLine("Fonk1 - Merhaba");
    Console.WriteLine("Fonk1 - 3 Kasim");
}
//Fonksiyon 2
//Parametre Almayan - Geri Dönüş Veren
int fonk2(){
    int a,b;
    b=3;
    a=10+b; 
    return a;
}
//Fonksiyon 3
//Parametre Alan - Geri Dönüş Vermeyen
void fonk3( string a, int b, bool c ){
    if(c==true){
        Console.WriteLine(a+":"+(b*b).ToString());
    }else{
        Console.WriteLine(a+":"+(b).ToString());
    }
}
//Fonksiyon 4
//Parametre Alan - Geri Dönüş Veren
int fonk4(int aci1, int aci2){
    int sonuc;
    sonuc=180-(aci1+aci2);
    return sonuc;
}



