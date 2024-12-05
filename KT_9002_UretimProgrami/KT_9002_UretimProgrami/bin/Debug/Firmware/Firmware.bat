cd Firmware
esptool.exe -p #COM_PORT# -b 921600 --before default_reset --after hard_reset write_flash -z --flash_mode dio --flash_freq 80m --flash_size detect 2686976 UHF24.spiffs.bin
esptool.exe -p #COM_PORT# -b 921600 --before default_reset --after hard_reset write_flash -z --flash_mode dio --flash_freq 80m --flash_size detect 0x10000 UHF24.ino.bin 0x8000 UHF24.ino.partitions.bin
echo Islem Tamamlandi!