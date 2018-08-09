import { HomeUIPage } from './app.po';

describe('home-ui App', () => {
  let page: HomeUIPage;

  beforeEach(() => {
    page = new HomeUIPage();
  });

  it('should display welcome message', done => {
    page.navigateTo();
    page.getParagraphText()
      .then(msg => expect(msg).toEqual('Welcome to app!!'))
      .then(done, done.fail);
  });
});
