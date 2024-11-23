# -*- mode: ruby -*-
# vi: set ft=ruby :

# Define the host IP addresses
hosts = {
  "ubuntu" => "192.168.33.10",
  "windows" => "192.168.33.11",
  #"mac" => "192.168.33.12",
}

Vagrant.configure("2") do |config|
  # Образ виртуальной машины Ubuntu
  config.vm.define "ubuntu" do |ubuntu|
    ubuntu.vm.box = "bento/ubuntu-20.04"
    ubuntu.vm.hostname = "VagrantVM"

    # Проброс портов
    ubuntu.vm.network "forwarded_port", guest: 80, host: 8000
    ubuntu.vm.network "forwarded_port", guest: 3306, host: 33060

    # Настройка сети
    ubuntu.vm.network "private_network", ip: hosts["ubuntu"]

    # Провайдер VirtualBox для Ubuntu
    ubuntu.vm.provider "virtualbox" do |v|
      v.name = "Ubuntu"
      v.gui = false
      v.memory = "2048" # 2 ГБ памяти
      v.cpus = 2        # 2 процессора
      # Настройка типов сетевых адаптеров
      v.customize ["modifyvm", :id, "--nictype1", "82540EM"]
      v.customize ["modifyvm", :id, "--nictype2", "82540EM"]
    end

    # Синхронизация папок для Ubuntu
    ubuntu.vm.synced_folder ".", "/home/vagrant/code", 
      owner: "www-data", group: "www-data"

    # Провизия для Ubuntu
    ubuntu.vm.provision "shell", path: "provision-ubuntu.sh"
  end

  # Windows Machine Configuration
  config.vm.define "windows" do |windows|
    windows.vm.box = "gusztavvargadr/windows-10"
    windows.vm.hostname = "windows-vm"
    # Try both private and public network
    windows.vm.network "private_network", ip: hosts["windows"]
    windows.vm.provider "virtualbox" do |v|
      v.name = "Windows"
      v.memory = "4096"
      v.cpus = 4
      # Enable all network adapter types
      v.customize ["modifyvm", :id, "--nictype1", "82540EM"]
      v.customize ["modifyvm", :id, "--nictype2", "82540EM"]
    end
    windows.vm.synced_folder ".", "C:/project"
    windows.vm.provision "shell", path: "provision-windows.sh"
  end

  # config.vm.define "mac" do |mac|
  #   mac.vm.box = "ramsey/macos-catalina"
  #   mac.vm.hostname = "mac-vm"
  #   mac.vm.network "private_network", ip: "192.168.56.12"
  #   mac.vm.provider "virtualbox" do |v|
  #     v.name = "Mac VM"
  #     v.memory = "4096"
  #     v.cpus = 2
  #     v.customize ["modifyvm", :id, "--nictype1", "82540EM"]
  #     v.customize ["modifyvm", :id, "--nictype2", "82540EM"]
  #   end
  #   mac.vm.synced_folder ".", "/Users/vagrant/project"
  #   mac.vm.provision "shell", path: "provision-mac.sh"
  # end
end
