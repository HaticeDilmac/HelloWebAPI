var builder = WebApplication.CreateBuilder(args);

//Get fonksiyonu �a�r�lm�� ve k�k�ne indi�imizde ise middleWear yap�s� mevcut
//app.MapGet("/", () => "Hello World!");

//Service(Container)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Servis kay�tlar�m�z tamamlanm�� olmaktad�r.

builder.Logging.ClearProviders();//Default olarak loglama mekanizmas� var demek
builder.Logging.AddConsole();
builder.Logging.AddDebug();


var app = builder.Build();
//Uygulamaya Swagger� kullan deriz.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //E�er sadece swagger ekleyip b�rak�rsak get i�leminde erorr al�r�z .
    //Neden ��nk�: MapController� eklememiz gerekiyor.
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
//Web aplication verecek.