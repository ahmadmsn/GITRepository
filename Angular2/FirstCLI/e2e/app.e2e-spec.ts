import { FirstCLIPage } from './app.po';

describe('first-cli App', () => {
  let page: FirstCLIPage;

  beforeEach(() => {
    page = new FirstCLIPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
