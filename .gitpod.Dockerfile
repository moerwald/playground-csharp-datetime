FROM gitpod/workspace-dotnet

RUN wget -q https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb \
    && dpkg -i packages-microsoft-prod.deb \
    && apt-get update 
    
    
RUN wget http://mirrors.edge.kernel.org/ubuntu/pool/main/i/icu/libicu60_60.2-3ubuntu3_amd64.deb \
    && wget http://security.ubuntu.com/ubuntu/pool/main/o/openssl1.0/libssl1.0.0_1.0.2n-1ubuntu5.3_amd64.deb \
    && dpkg -i libicu60_60.2-3ubuntu3_amd64.deb libssl1.0.0_1.0.2n-1ubuntu5.3_amd64.deb    
    
RUN echo "deb [arch=amd64] https://packages.microsoft.com/ubuntu/18.04/prod bionic main" >> /etc/apt/sources.list.d/microsoft-prod.list
RUN  apt-get update \
     && apt install -y powershell
     
RUN apt-get update && apt-get -y -o APT::Install-Suggests="true" install dotnet-sdk-3.0
