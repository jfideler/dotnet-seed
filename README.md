# dotnet-seed
A simple web app using DotNetCore -This was created on and runs on a MAC!

#Steps
1.) on a MAC:  first install HomeBrew (so you can install openssl)
[ source: http://brew.sh/]

/usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"

2.) install open ssl and set the environment
[source: https://www.microsoft.com/net/core#macos]

brew update
brew install openssl

ln -s /usr/local/opt/openssl/lib/libcrypto.1.0.0.dylib /usr/local/lib/

ln -s /usr/local/opt/openssl/lib/libssl.1.0.0.dylib /usr/local/lib/


3.) install dotnetcore sdk
[source: https://go.microsoft.com/fwlink/?LinkID=827526]

4.) then the normal stuff (I've added web stuff to the original code)
git clone https://github.com/jfideler/dotnet-seed.git <folder-name>

cd <folder-name>
dotnet new (may not be necessary)
dotnet restore  (sort of like 'npm install')
dotnet run (sort of like 'npm start')


