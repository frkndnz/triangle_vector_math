# Vectörel Matematik Formülleri ile Üçgen Hesapları

![resim](https://images.squarespace-cdn.com/content/5c8c4dd190f904ba4fd6c023/1559766069525-6W7SD5K94SG4YHT7CYZX/shutterstock_795328972.jpg?format=1500w&content-type=image%2Fjpeg)

## Vector math
	Unity math kütüphanesine [buradan](https://docs.unity3d.com/ScriptReference/Mathf.html) ulaşabilirsiniz.
+ dizi ve vector 

	+ `vector3[] dizi  ; ` 					vectorel boş dizi oluştur 	
	+ `a = dizi[0] = new Vector3(0, 0, 0); `	dizi ye yeni nokta atama  
	+ `vector3 a ; `						 	vectorel 1 nokta   
 
+ matematiksel operatörler
 
 	+ `Random.Range(minX, maxX) ;` # 		random sayı üret
 	+ `Vector3.dot(a,b)  ;` #          	a noktası ile b noktasının nokta çarpımı
 	+ `Vector3.Magnitude(a) ; `#       	a vektörünün uzunluğu   
 	+ `Mathf.Acos(a)  ; `					a nın arccos'unu alma  
 	+ `Mathf.Cross(a,b) ;`            	a ve b arasında çapraz çarpım
 	+ `Vector3.Distance(a,b) ;` 			iki nokta arası uzaklık
 	+ `k.normalized  ;`					k vektörünü normalize etmek (vektor distance =1)
 	+ `açı* Mathf.Rad2Deg`				radyan çevirme

+ Çizdirmek

	+ `Debug.DrawLine(a,b,Color.red,100f)`	a noktası ile b noktası arasında kırmızı bir doğru çizdir