var builder = WebApplication.CreateBuilder(args);

//Get fonksiyonu çaðrýlmýþ ve köküne indiðimizde ise middleWear yapýsý mevcut
//app.MapGet("/", () => "Hello World!");

//Service(Container)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Servis kayýtlarýmýz tamamlanmýþ olmaktadýr.

builder.Logging.ClearProviders();//Default olarak loglama mekanizmasý var demek
builder.Logging.AddConsole();
builder.Logging.AddDebug();


var app = builder.Build();
//Uygulamaya Swaggerý kullan deriz.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //Eðer sadece swagger ekleyip býrakýrsak get iþleminde erorr alýrýz .
    //Neden çünkü: MapControllerý eklememiz gerekiyor.
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
//Web aplication verecek.