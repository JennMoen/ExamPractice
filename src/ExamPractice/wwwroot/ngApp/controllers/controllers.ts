namespace ExamPractice.Controllers {

    export class HomeController {
        public message = 'Hello from the home page! Look at the list of doggies.';
        public dogs;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/dogs').then((results) => {
                this.dogs = results.data;
            });
        }


    }



    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
