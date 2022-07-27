# Best Restaurant

#### By Joseph Jack, Filmer Tolentino, Claire Thorington

## Description

Best Restaurant is an application allowing the user to create, edit, and store a list of restaurants organized by cuisine type. 


## Logistics

|                    | Minimum Product Features |
| ------------------ | ------------------------ |
| :heavy_check_mark: |                          |
| :heavy_check_mark: |                          |
| :heavy_check_mark: |                          |

## Setup/Installation Requirements

1. Clone this projects repository into your local directory following [these](https://www.linode.com/docs/development/version-control/how-to-install-git-and-clone-a-github-repository/) instructions.

2. Navigate to project directory from your terminal by entering the following:

```
cd BestRestaurant.Solution
```

3. Download [.NET Core](https://docs.microsoft.com/en-us/dotnet/core/install/windows?pivots=os-windows&tabs=net60)

4.  Install:
`dotnet tool install -g`

5. Navigate to `BestRestaurant` directory and run `$ dotnet run build` in your terminal.

6. Within the same project folder enter `dotnet watch run` to open a live server.

8. Go to your browser and enter the url:
`http.://localhost:5000`

### MySQL Install and Configuration:
* Windows Installation:

1. Start by downloading the MySQL Web Installer from the [MySQL Downloads](https://dev.mysql.com/downloads/installer/) page. This will allow you to install both the MySQL Community Server and the MySQL Workbench.
2. On the configuration page of the installer select the following options:
* Use legacy password encryption
* Set your password
3. Open the terminal and enter the command: *'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile
4. Download the MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391) if you haven't already.
5. Open Local Instance 3306 with the password you set.
6. Import database file from project directory `joseph_jack(2)` in MySQL Workbench to import database for you to recreate.

*  Create `appsettings.json` file in top of project directory and copy in the following, with the password:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurant;uid=root;pwd=[YOUR_PASSWORD_HERE];"
  }
}

## Technologies Used

* C#
* .NET Core
* Entity
* MySQL Workbench




## Known Bugs

* Any known issues


## License

* MIT

## Copyright

&copy; Joseph Jack, Claire Thorington, Filmer Tolentino 2022

