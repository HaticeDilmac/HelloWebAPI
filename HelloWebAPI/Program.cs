var builder = WebApplication.CreateBuilder(args);

//Get fonksiyonu çaðrýlmýþ ve köküne indiðimizde ise middleWear yapýsý mevcut
//app.MapGet("/", () => "Hello World!");

//Service(Container)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Servis kayýtlarýmýz tamamlanmýþ olmaktadýr.


var app = builder.Build();
//Uygulamaya Swaggerý kullan deriz.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //Eðer sadece swagger ekleyip býrakýrsak get iþleminde erorr alýrýz .
    //Neden çünkü: MapControllerý eklememiz gerekiyor.
}

app.MapControllers();
app.Run();
//Web aplication verecek.
