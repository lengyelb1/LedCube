import time
from selenium import webdriver
from selenium.webdriver.chrome.service import Service
from webdriver_manager.chrome import ChromeDriverManager

bongeszo=webdriver.Chrome()
bongeszo.implicitly_wait(10)
bongeszo.get('https://szallas.sulla.hu/')
time.sleep(3)

elem=bongeszo.find_element("input", "Email")
#elem.click()
elem.send_keys("user@kodbazis.hu")
time.sleep(3)
elem=bongeszo.find_element("input", "Jelszó")
#elem.click()
elem.send_keys("teszt")
time.sleep(3)
elem=bongeszo.find_element("link text", "Küldés")
elem.click()
bongeszo.save_screenshot("Bejelentkezes.png")
time.sleep(3)
elem=bongeszo.find_element("link text", "Chelsea Perfect")
bongeszo.save_screenshot("Chelsea.png")
time.sleep(3)
elem.click()
bongeszo.save_screenshot("Kattint.png")
time.sleep(2)
elem=bongeszo.find_element("link text", "Kijelentkezés")
elem.click()
bongeszo.save_screenshot("Kilep.png")
time.sleep(3)


#elem=bongeszo.find_element("link text", "Felvételi", "Pontszámítás")
#elem.click()
#bongeszo.save_screenshot('Pontok.png')
#time.sleep(3)
#bongeszo.get('https://www.felvi.hu/')
#elem.click()
#bongeszo.save_screenshot('Fooldal.png')
#time.sleep(3)
