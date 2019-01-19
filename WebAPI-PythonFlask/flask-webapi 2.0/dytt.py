import urllib.request
import urllib.parse
import random
import urllib
import re
from bs4 import BeautifulSoup
from urllib import parse
import movies_detail


def Spider_Title(s):

  url = 'http://s.ygdy8.com/plus/so.php?typeid=1&keyword='+urllib.parse.quote(s,encoding='gb2312')
  #print(url)

  req = urllib.request.Request(url)
  req.add_header('User-Agent','Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36')

  response = urllib.request.urlopen(req)
  html = response.read().decode('gb18030',errors='ignore')
  #print(html)
  
  soup = BeautifulSoup(html , 'lxml')
  lists = []
  dic={}
  
  for k in soup.find_all('table',attrs={'border':'0','width':'100%'}):
    for i in k.find_all('td',attrs={'width':'55%'}):
      for j in i.find_all('a'):
        try:
          dic['link'] = 'https://www.ygdy8.com'+str(j['href'])
          dic['name'] = j.text.replace('<font color="red">','').replace('</font>','')
          #print(dic['name'])
        except Exception as e:
          continue

    for i in k.find_all('td',attrs={'height':'56','colspan':'3'}):
      try:
        #print(i.text)
        x = str(re.findall('国 家([\s\S]+?)◎',i.text)).replace('\\u3000','').replace(']','').replace('[','').replace("'",'').replace(' ','')
        y = str(re.findall('产 地([\s\S]+?)◎',i.text)).replace('\\u3000','').replace(']','').replace('[','').replace("'",'').replace(' ','')
        if x != '':
          dic['place'] = x
        else:
          dic['place'] = y
        x = str(re.findall('类 别([\s\S]+?)◎',i.text)).replace('\\u3000','').replace(']','').replace('[','').replace("'",'').replace(' ','')
        y = str(re.findall('类 型([\s\S]+?)◎',i.text)).replace('\\u3000','').replace(']','').replace('[','').replace("'",'').replace(' ','')
        if x != '':
          dic['type'] = x
        else:
          dic['type'] = y
        dic['language'] = str(re.findall('语 言([\s\S]+?)◎',i.text)).replace('\\u3000','').replace(']','').replace('[','').replace("'",'').replace(' ','')
        dic['rate'] = str(re.findall('评分([\s\S]+?) ',i.text)).replace('\\u3000','').replace(']','').replace('[','').replace("'",'').replace(' ','')
      except Exception as e:
        continue

    lists.append(dic.copy())
    dic.clear();
    
  return lists


def New_Movies_List():

  url = 'https://www.dytt8.net/html/gndy/dyzz/index.html'
  req = urllib.request.Request(url)
  req.add_header('User-Agent','Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36')

  response = urllib.request.urlopen(req)
  html = response.read().decode('gb18030',errors='ignore')

  lists=[]
  dic={}

  soup = BeautifulSoup(html , 'lxml')
  #print(html)
  for i in soup.find_all('a',attrs={'class':'ulink'}):
    try:
      dic['link'] = i['href']
      s = str(re.findall('《([\s\S]+?)》',i.text))
      dic['name'] = s.replace('\\u3000','').replace(']','').replace('[','').replace("'",'').replace(' ','')
      dic['quality'] = str(re.findall(s + '\\]\\[([\s\S]+?)\\]',html)).replace('\\u3000','').replace(']','').replace('[','').replace("'",'').replace(' ','')
      dic['place'] = str(re.findall(s + '\\][\s\S]+?产 地([\s\S]+?)◎',html)).replace('\\u3000','').replace(']','').replace('[','').replace("'",'').replace(' ','')
      dic['type'] = str(re.findall(s + '\\][\s\S]+?类 别([\s\S]+?)◎',html)).replace('\\u3000','').replace(']','').replace('[','').replace("'",'').replace(' ','')
      dic['language'] = str(re.findall(s + '\\][\s\S]+?语 言([\s\S]+?)◎',html)).replace('\\u3000','').replace(']','').replace('[','').replace("'",'').replace(' ','')
      lists.append(dic.copy())
      dic.clear()
    except Exception as e:
      continue
    
  return lists


def Local_Movies_List(url):

  req = urllib.request.Request(url)
  req.add_header('User-Agent','Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36')

  response = urllib.request.urlopen(req)
  html = response.read().decode('gb18030',errors='ignore')

  lists=[]
  dic={}
  soup = BeautifulSoup(html , 'lxml')

  for i in soup.find_all('a',attrs={'class':'ulink','href':True}):
    try:
      dic['link'] = i['href']
      s = str(re.findall('《([\s\S]+?)》',i.text))
      dic['name'] = s.replace('\\u3000','').replace(']','').replace('[','').replace("'",'').replace(' ','')
      dic['quality'] = str(re.findall(s + '\\]\\[([\s\S]+?)\\]',html)).replace('\\u3000','').replace(']','').replace('[','').replace("'",'').replace(' ','')
      dic['type'] = str(re.findall(s + '\\][\s\S]+?类 别([\s\S]+?)◎',html)).replace('\\u3000','').replace(']','').replace('[','').replace("'",'').replace(' ','')
      dic['language'] = str(re.findall(s + '\\][\s\S]+?语 言([\s\S]+?)◎',html)).replace('\\u3000','').replace(']','').replace('[','').replace("'",'').replace(' ','')
      lists.append(dic.copy())
      dic.clear()
    except Exception as e:
      continue

  return lists

