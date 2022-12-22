import base64
import requests


url = 'aHR0cHM6Ly9zaGVldGFwaS5teXNob3BpZnkuY29tL2FkbWluL2FwaS8yMDIyLTA0L3BhZ2VzLzg4OTE2NTU3OTg2L21ldGFmaWVsZHMuanNvbg=='
url = base64.b64decode(url).decode('utf-8')

token = 'c2hwYXRfOGViZjY0NTk1MTA3ZDA3OTVhYTg4NmI2ZDg5ZDc1NGM='
token = base64.b64decode(token).decode('utf-8')

headers = {'X-Shopify-Access-Token': token, 'Content-Type': 'application/json'}

json_data = {
    'metafield': {
        'namespace': 'userid',
        'key': 'KhenJX-61D4-CA43-164F-1CAC-D865-AAC7-7EC7-6E6A-8399-0A13',
        'value': 'KhenJX-61D4-CA43-164F-1CAC-D865-AAC7-7EC7-6E6A-8399-0A13;VIP;2024-04-01',
        'description': 'Mini',
        'type': 'single_line_text_field',
    },
}

response = requests.post(url=url, headers=headers, json=json_data)
print(response.text)
