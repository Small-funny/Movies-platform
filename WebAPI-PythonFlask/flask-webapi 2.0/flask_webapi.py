from flask import Flask, url_for, request, Response,jsonify
import json
import dytt
import movies_detail
from functools import wraps

app = Flask(__name__)

app.config['JSON_AS_ASCII'] = False

@app.route('/')
def api_root():
    return 'Welcome'

@app.route('/MoviesTitle',endpoint='func2')
def Movies_Download1():
    name = request.args.get('name')
    lists = dytt.Spider_Title(name)
    return jsonify(lists)

@app.route('/NewMovies/',endpoint='func3')
def New_Movies():
    lists = dytt.New_Movies_List()
    return jsonify(lists)

@app.route('/ChineseMovies/',endpoint='func4')
def Chinese_Movies():
    lists = dytt.Local_Movies_List('https://www.dytt8.net/html/gndy/china/index.html')
    return jsonify(lists)

@app.route('/RihanMovies/',endpoint='func5')
def Rihan_Movies():
    lists = dytt.Local_Movies_List('https://www.dytt8.net/html/gndy/rihan/index.html')
    return jsonify(lists)

@app.route('/WesternMovies/',endpoint='func6')
def Western_Movies():
    lists = dytt.Local_Movies_List('https://www.dytt8.net/html/gndy/oumei/index.html')
    return jsonify(lists)

@app.route('/MoviesDetail/<link1>',endpoint='func7')
def Movies_Detail(link1):
    link1 = link1.replace("'","/")
    if link1[0:5] != 'https':
        link1='https://www.dytt8.net' + link1
    print(link1)
    m = movies_detail.Movies_Detail(link1)
    m.init()
    lists = []
    dic = m.Spider_Messages()
    lists.append(dic)
    return jsonify(lists)

@app.route('/MoviesLink/<link2>',endpoint='func8')
def Movies_Download2(link2):
    link2 = link2.replace("'","/")
    if link2[0:5] != 'https':
        link2='https://www.dytt8.net' + link2
    print(link2)
    m = movies_detail.Movies_Detail(link2)
    m.init()
    links=m.Spider_Download_Link()
    return jsonify(links)


if __name__ == '__main__':
    app.run()

#'html'gndy'dyzz'20160215'50259.html
