1.	Getting the List of Items
curl --insecure https://localhost:7010/api/glossary



2.	Getting Single Item 
a.	curl --insecure https://localhost:7010/api/glossary/MVC

b.	 curl --insecure https://localhost:7010/api/glossary/HTML

c.	curl --insecure https://localhost:7010/api/glossary/OpenID

3.	Creating an item
curl --insecure -X POST -d "{\"term\": \"MFA\", \"definition\":\"An authentication process.\"}" -H "Content-Type:application/json" https://localhost:7010/api/glossary



4.	Updating an Item
curl --insecure -X PUT -d "{\"term\": \"MVC\", \"definition\":\"Modified record of Model View Controller.\"}" -H "Content-Type:application/json" https://localhost:7010/api/glossary 

5.	Delete an Item
curl --insecure --request DELETE --url https://localhost:7010/api/glossary/openid 
