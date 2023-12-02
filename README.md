## Package need to install 
 -Microsoft.EntityFrameworkCore 7.0.14
 - Microsoft.EntityFrameWorkCore.SqlServer 7.0.14
 - Microsoft.EntityFrameworkCore.Tools 7.0.14 (for commands)



 ## Script
 ````bash
 -Scaffold-DbContext "Server=RUSSELVIEMWAKIN\AKEMSSQLSERVER;Database=Employee;User Id=sa;Password=p@ssw0rd;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Context
``````

 ## Securing your Connection String
  -include this to appsettings.json  
    ### Code
    ````bash
    "ConnectionStrings": {
    "DefaultConnection": "Server=RUSSELVIEMWAKIN\\AKEMSSQLSERVER;Database=Student;User Id=sa;Password=p@ssw0rd;TrustServerCertificate=True;"
     },
     ``````

  -in your context inject IConfifuration
     ### Code
          private readonly IConfiguration _configuration;

````bash
          public StudentContext(DbContextOptions<Your Context here> options, IConfiguration configuration)
              : base(options)
          {
              _configuration = configuration;
          }

          #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
           => optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:DefaultConnection"]);
``````

## In Program.cs
 - add your context before build
  ### Code
     #### Register DB CONTEXT
     builder.Services.AddDbContext<Your Context>();
     
     var app = builder.Build();
         

-------------------------------------------------------------Development---------------------------------------------------------
### Intitial Migration
````bash
 -add-migration <Message>
``````

### Update Database
````bash
-update-database
``````

### if you want to Roll Back
````bash
-dotnet ef database update <PreviousMigrationName>
``````
       
