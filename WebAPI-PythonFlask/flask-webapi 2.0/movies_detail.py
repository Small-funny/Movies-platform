import urllib.request
import urllib.parse
import urllib
import re


class Movies_Detail:

  link = ''
  dic = {}
  html = ''
  image = []
  
  def __init__(self , link):
    self.link = link
    print(link)

  def init(self):
    req = urllib.request.Request(self.link)
    req.add_header('User-Agent','Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36')

    response = urllib.request.urlopen(req)
    self.html = response.read().decode('gb18030',errors='ignore')
    #print(self.html)

  def Spider_Messages(self):

    #print(re.findall('◎简　　介 <br><br>([\s\S]+?)<br',self.html))
    try:
      self.dic['name'] = str(re.findall('片　　名([\s\S]+?)<',self.html)).replace('\\u3000','').replace(']','').replace('[','')
      self.dic['place'] = str(re.findall('◎产　　地([\s\S]+?)<',self.html)).replace('\\u3000','').replace(']','').replace('[','')
      if self.dic['place'] == '':       
         self.dic['place'] = str(re.findall('◎国　　家([\s\S]+?)<',self.html)).replace('\\u3000','').replace(']','').replace('[','')
      self.dic['type'] = str(re.findall('类　　别([\s\S]+?)<',self.html)).replace('\\u3000','').replace(']','').replace('[','')
      self.dic['language'] = str(re.findall('◎语　　言([\s\S]+?)<',self.html)).replace('\\u3000','').replace(']','').replace('[','')
      self.dic['date'] = str(re.findall('上映日期([\s\S]+?)<',self.html)).replace('\\u3000','').replace(']','').replace('[','')
      self.dic['rate_db'] = str(re.findall('豆瓣评分([\s\S]+?)f',self.html)).replace('\\u3000','').replace(']','').replace('[','')
      self.dic['rate_IMDb'] = str(re.findall('IMDb评分([\s\S]+?)f',self.html)).replace('\\u3000','').replace(']','').replace('[','').replace('&hellip;','...')
      if self.dic['rate_IMDb'] == '':
         self.dic['rate_IMDb'] = str(re.findall('IMDB评分([\s\S]+?)f',self.html)).replace('\\u3000','').replace(']','').replace('[','').replace('&hellip;','...')
      self.dic['duration'] = str(re.findall('◎片　　长([\s\S]+?)<',self.html)).replace('\\u3000','').replace(']','').replace('[','')
      self.dic['actors'] = str(re.findall('◎主　　演([\s\S]+?)<',self.html)).replace('\\u3000','').replace(']','').replace('[','')
      self.dic['describe'] = str(re.findall('◎简　　介　<br /><br />([\s\S]+?)<br',self.html)).replace('\\u3000','').replace(']','').replace('[','').replace('&hellip;','...').replace('&middot','')
      if self.dic['describe'] == '':
        self.dic['describe'] = str(re.findall('◎简　　介 <br /><br />([\s\S]+?)<br',self.html)).replace('\\u3000','').replace(']','').replace('[','').replace('&hellip;','...').replace('&middot','')
    except Exception as e:      
      return self.dic
    
    return self.dic

  def Spider_Download_Link(self):
    Download_Links1 = re.findall('''href="magnet:([\s\S]+?)"''',self.html)
    #print(Download_Links1)
    Download_Links2 = []
    num = 1
    dic = {}
    for i in Download_Links1:
      try:
        dic[str(num)] = 'magnet:'+i;
        Download_Links2.append(dic.copy())
        num += 1
        dic.clear()
      except Exception as e:
        continue
    #print(self.html)
    if Download_Links2 == []:
      Download_Links1 = re.findall('''href="ftp:([\s\S]+?)"''',self.html)
      num = 1
      dic = {}
      for i in Download_Links1:
        try:
          dic[str(num)] = 'ftp:'+i;
          Download_Links2.append(dic.copy())
          num += 1
          dic.clear()
        except Exception as e:
          continue
      
    #print(Download_Links2)
    return Download_Links2  #.replace("'",'').replace(']','').replace('[','')
  

if __name__=='__main__':
  m = Movies_Detail('https://www.ygdy8.com/html/gndy/dyzz/20111103/34939.html')
  m.init()
  dic = m.Spider_Messages()
  link=m.Spider_Download_Link()

