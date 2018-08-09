# HomeAutomation Project
This solution contains 3 projects 
<ol>
<li>Alarm (Console app)</li>
<li>ConditionsDataCollector (Console app)</li>
<li>HomeAutomations (Web API app)</li>
</ol>
<strong>Alarm (Console app)</strong></br>
This is a simple .Net console app that is running on a raspberry pi with some PIR sensors and a custom siren. 
When the app is in armed mode and the sensor detect motion the system trigger the siren for 10 minutes
</br><strong>HomeAutomations (Web API app)</strong></br>
This is the app that communicate with my custom website/pwa when needed.
</br><strong>HomeUI (Angular 2 app)</strong></br>
This Angular app collecting data from HomeAutomations app via api and show them to the user. This app also sending commands to some relays or sensors by the same API (HomeAutomations)
