import { Bootstrap02Page } from './app.po';

describe('bootstrap02 App', () => {
  let page: Bootstrap02Page;

  beforeEach(() => {
    page = new Bootstrap02Page();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
